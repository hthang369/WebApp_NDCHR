$(function () {
    $(document).on('change', '#dteToDate', function () {
        var dtFrom = new Date($('#dteFromDate').val());
        var dtTo = new Date($(this).val());
        var dbTime = GetDateDiffWorking(dtFrom, dtTo);
        $('#txtRegDays').val(dbTime);
        if ($('#txtRegDays').val() > 1)
            $('#lkeShiftType').attr('disabled', 'disabled');
        else
            $('#lkeShiftType').removeAttr('disabled', 'disabled');
    });
    $(document).on('change', '#dteFromDate', function () {
        var dtFrom = new Date($(this).val());
        var dtTo = new Date($('#dteToDate').val());
        var dbTime = GetDateDiffWorking(dtFrom, dtTo);
        $('#txtRegDays').val(dbTime);
        if ($('#txtRegDays').val() > 1)
            $('#lkeShiftType').attr('disabled', 'disabled');
        else
            $('#lkeShiftType').removeAttr('disabled', 'disabled');
    });
    $(document).on('change', '#txtRegDays', function () {
        var dtFrom = new Date($('#dteFromDate').val());
        var dtTo = new Date($('#dteToDate').val());
        var dbTime = GetDateDiffWorking(dtFrom, dtTo);
        if (dbTime - $(this).val() > 0.5) {
            alert('Bạn không được nhập số ngày nghỉ nhỏ hơn ' + ((Math.round(dbTime - 1) + 0.5) + ' ngày'));
            $(this).val(dbTime);
        }
    });
    $(document).on('click', '#lkeShiftType', function () {
        if ($(this).val() != "")
            $('#txtRegDays').val(0.5);
        else
            $('#txtRegDays').val(1);
    });
});
function GetDateDiffWorking(dtFrom, dtTo) {
    var dbTime = (dtTo.getTime() - dtFrom.getTime()) / (1000 * 3600 * 24) + 1;
    var d = dtFrom.getDay();
    var dtTmp = dtFrom;
    var count = 0;
    while (dtTmp <= dtTo) {
        if (dtTmp.getDay() == 0) count++;
        dtTmp.setDate(dtTmp.getDate() + 1);
    };
    return dbTime - count;
}
var GMCWebCore = {
    CheckSession: function(){
        $.post('/Home/CheckSession', {}, function (result) {
            if (result == 'FAIL') location.reload();
        }).fail(function () {
            alert("Có lỗi trong quá trình xử lý!");
        })
    },
    Register: function (urlAction) {
        $(document).on('click', '.btnAddNew', function () {
            GMCWebCore.CheckSession();
            if ($('#dteFromDate').val() == "") {
                alert("Vui lòng chọn từ ngày!");
                return;
            }
            if ($('#dteToDate').val() == "") {
                alert("Vui lòng chọn đến ngày!");
                return;
            }
            var dtFrom = new Date($('#dteFromDate').val());
            var dtNow = new Date();
            if (GetDateDiffWorking(dtFrom, dtNow) > 7) {
                $(this).val(dtNow.toLocaleDateString());
                alert("Không được phép chọn ngày bắt đầu nhỏ hơn ngày hiện tại 7 ngày!");
                return;
            }
            if ($('#FK_HREmployeeLeaveTypeID').val() == "") {
                alert("Vui lòng chọn loại phép!");
                return;
            }
            if ($('#chkRegisterMember').is(":checked") && $("#lkeEmployee").val() == "") {
                alert("Vui lòng chọn nhân viên để đăng ký phép hộ!");
                return;
            }
            var strData = "";
            $.each($('#frmRegisterOffWork').serializeArray(), function (i, n) {
                var val = n['value'] == "on" ? true : n['value'];
                strData += n['name'] + "=" + val + "&";
            });
            $.post(urlAction, { oEmplOffWork: strData }, function (result) {
                if (result == "OK") {
                    $('#showScreen').html('').modal('hide');
                    $('.btnRefresh').click();
                }
                else
                    alert(result);
            }).fail(function () {
                alert("Có lỗi trong quá trình xử lý!");
            });
        });
    },
    showFromRegister: function (urlAction) {
        $('.btnRegister').click(function () {
            GMCWebCore.CheckSession();
            $('#showScreen').modal('show').html('').load(urlAction, { sType: $(this).data('type') }, function (response, status, xhr) {
                if (status == 'error') {
                    alert("Có lỗi trong quá trình xử lý!");
                    $('#showScreen').modal('hide');
                }
            });
        });
    },
    ApprovalDocument: function (urlAction) {
        $(document).on('click', '.btnApproval', function () {
            GMCWebCore.CheckSession();
            $.post(urlAction, { iInboxItemID: $(this).data('id'), strMessenger: $(".fldMessage").val(), strRemark: $(".fldRemark").val() }, function (result) {
                $('#showScreen').html('').modal('hide');
                $('.btnRefresh').click();
            }).fail(function () {
                alert("Có lỗi trong quá trình xử lý!");
            });
        });
    },
    RejectDocument: function (urlAction) {
        $(document).on('click', '.btnReject', function () {
            GMCWebCore.CheckSession();
            $.post(urlAction, { iInboxItemID: $(this).data('id'), strMessenger: $(".fldMessage").val(), strRemark: $(".fldRemark").val() }, function (result) {
                $('#showScreen').html('').modal('hide');
                $('.btnRefresh').click();
            }).fail(function () {
                alert("Có lỗi trong quá trình xử lý!");
            });
        });
    },
    SubmitDocument: function (urlAction) {
        $(document).on('click', '.btnSubmit', function () {
            GMCWebCore.CheckSession();
            $.post(urlAction, { iObjectID: $(this).data('id') }, function (result) {
                if (result == 'OK') {
                    $('#showScreen').html('').modal('hide');
                    $('.btnRefresh').click();
                }
                else {
                    alert(result);
                }
            }).fail(function () {
                alert("Có lỗi trong quá trình xử lý!");
            });
        });
    },
    DeleteDocument: function (urlAction) {
        $(document).on('click', '.btnDelete', function () {
            GMCWebCore.CheckSession();
            if (confirm("Bạn có chắc muốn xóa!")) {
                $.post(urlAction, { iObjectID: $(this).data('id') }, function (result) {
                    $('.btnRefresh').click();
                }).fail(function () {
                    alert("Có lỗi trong quá trình xử lý!");
                });
            }
        });
    },
    CancelDocument: function (urlAction) {
        $(document).on('click', '.btnCancel', function () {
            GMCWebCore.CheckSession();
            if (confirm("Bạn có chắc muốn hủy!")) {
                $('#showScreen').modal('show').html('').load(urlAction, { iObjectID: $(this).data('id') }, function (response, status, xhr) {
                    if (status == 'error') {
                        alert("Có lỗi trong quá trình xử lý!");
                        $('#showScreen').modal('hide');
                    }
                });
            }
        });
    },
    ReloadEmployeeOffWork: function (urlAction) {
        $(document).on('change', '#lkeEmployee', function () {
            GMCWebCore.CheckSession();
            $.post(urlAction, { iObjectID: $(this).val() }, function (result) {
                var obj = JSON.parse(result);
                $('.SoNgayPhepNam').val(obj.SoNgayPhepNam).text(obj.SoNgayPhepNam);
                $('.SoNgayNghiThangNay').val(obj.SoNgayNghiThangNay).text(obj.SoNgayNghiThangNay);
                $('.SoNgayNghiThangTruoc').val(obj.SoNgayNghiThangTruoc).text(obj.SoNgayNghiThangTruoc);
                $('.ConLai').val(obj.ConLai).text(obj.ConLai);
            }).fail(function () {
                alert("Có lỗi trong quá trình xử lý!");
            });
        });
    },
    ClearCacheBrowser: function () {
        $(document).on('click', '.btnClearCache', function () {
            if (confirm('Bạn có chắc muốn xóa bộ nhớ đệm!')) {
                $.post('/Home/ClearCacheBrowser', {}, function (result) {
                    if (result == 'OK') {
                        alert('Xóa bộ nhớ đệm thành công!');
                        location.reload();
                    }
                }).fail(function () {
                    alert("Có lỗi trong quá trình xử lý!");
                });
            }
        });
    }
}