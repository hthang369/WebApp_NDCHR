// JavaScript Document

$(document).ready(function(){
	//$("#log, .login").corner("15px");
	//$(".error, .warning").corner();
	//$(".warning, #load, .error").hide();
	$("#frmlogin").validate({
		errorElement: "em",
		rules:{
			usadmin: 'required',
			pwadmin: 'required'
		},
		messages:{
			usadmin: "Tên đăng nhập là bắt buộc.",
			pwadmin: 'Mật khẩu là bắt buộc.'
		},
		submitHandler:function(form){
			var user=$("#usadmin").val();
			var pass=$("#pwadmin").val();
			$("#load").show();
			dulieu = $("#frmlogin").serialize();
			var url="admin/manager_account/login";
			$.post(url,dulieu,function(data){
				if(data!="ok"){
					$(".error").hide();
					$(".warning").text(data);
					$(".warning").show();
					$("#load").hide();
				}
				else{
					$(".error").hide();
					$(".warning").hide();
					$("#load").hide();
					document.location="./admin/welcome";
				}
			});
			return false;
		}
	})
	$('#unpass').click(function(){
		$('#popup_wrapper').html(openPopup1('Lấy lại mật khẩu','<label>Tài khoản / Email:</label> <input type="email" placeholder="Nhập tài khoản hoặc email bạn đã đăng ký" id="email" class="input-text" name="Email" />')).show();
		$('#popup_box').css('width',435);
		Turnoff.init();
	})
	$('#btnok').live('click',function(){
		re=/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/;
		mail = $('#email').val();
		if(!re.test(mail)) alert('Email không hợp lệ');
		else{
			$.post('admin/manager_welcome/quenpass',{mail:mail},function(data){
				if(data){
					alert('Chúc mừng bạn đã lấy lại mật khẩu thành công! Bạn vui lòng kiểm tra lại email');
					$('#popup_wrapper').empty().hide();
				}else alert('Có lỗi trong lúc xử lý!');
			})
		}
	})
	$('.box_close,#btncancle').live('click',function(){
		$('#popup_wrapper').empty().hide();
	})
});
/* =================================================FB LOGIN ==================================================*/
(function(d){
	var js, id = 'facebook-jssdk', ref = d.getElementsByTagName('script')[0];
	if (d.getElementById(id)) {return;}
	js = d.createElement('script'); js.id = id; js.async = true;
	js.src = "//connect.facebook.net/en_US/all.js";
	ref.parentNode.insertBefore(js, ref);
}(document));
window.fbAsyncInit = function() {
	FB.init({
		appId : FCB.APP_ID,
		channelUrl : FCB.URL+'/admin', 
		status : true,
		cookie : true,
		xfbml : true
	});
};
function FBLogin(){
	FB.login(function(response){
		if(response.authResponse){
			FB.api('/me', function(response) {
				$.post('admin/manager_welcome/login_facebook',{name:response.name,email:response.email},function(data){
					if(data!='ok'){
						$(".error").hide();
						$('.warning').html(data).show();
					}else{
						$(".error,.warning").hide();
						document.location = './admin/welcome';
					}
				})
			})
		}else{
			$('.warning').html('Bạn đã hủy kết nối fb').show();
		}
	}, {scope: 'email'});
}