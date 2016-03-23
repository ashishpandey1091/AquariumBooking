/* 
 * home.js consists of functionalities related to home page. *Login* *Registration* *Logout* *Saving user in cookie*
 * *Login and user saving in cookie*
 * *Logout and removing user from cookie*
 * *Register and save user in cookie*
 */

$(document).ready(function(){
    
   //var name = $.cookie("username");
   // console.log("in home");
    
   //  if(name == "null" || name == undefined){
   //         console.log("in if");
   //         $("#myaccount").hide();
   //         $("#loginlinks").show();
   //         $("#username").html(" ");
   //  }else{
   //         console.log("in else");
   //         $("#myaccount").show();
   //         $("#loginlinks").hide();
   //         $("#username").html(name);   
   //  }
    
    
    /** login functionality **/
    
    //$(document).on("click","#lgnbtn",function(){
        
                   
    //               console.log("in submit login");
    //               var username = $("#login").find("#user").val();
    //               var password = $("#login").find("#password").val();
                    
               
               
    //           $.each(user, function(a, b) {
    //            if (username === b.username || username === b.email) {
    //                console.log(b.username);
    //                console.log(b.password);
    //                if (password === b.password) {
    //                  console.log("in password");
    //                    $.cookie("username", b.username,{path:'/'});
    //                    $.cookie("email", b.email,{path:'/'});
    //                    $.cookie("firstname", b.firstname,{path:'/'});
    //                    $.cookie("lastname", b.lastname,{path:'/'});
    //                    $.cookie("contact", b.contact,{path:'/'});
    //                    $("#login").modal("hide");
                        
    //                   /** setTimeout(function() {
    //                        window.location.href = window.location.origin + window.location.pathname;
    //                    }, 500);
    //                    removeOverlay();**/
    //                    $("#myaccount").show();
    //                    $("#loginlinks").hide();
    //                    name = $.cookie("username");
    //                    $("#username").html(name);
    //                    return;
    //                } else {
    //                    alert("please enter the password correctly");
    //                }
    //            }
    //        });
            
    //        if (!$.cookie("username")) {
    //            alert("Invalid username or password. Please try again.");
    //        }
            
    //});

    /** login functionality  ends **/
            
    /** Start of Forgot password Alert **/
            //$(document).on("click","#forgotPassword",function(){
            
            //    var fgt = prompt("Please enter the e-mail address of your account");
            //        if (fgt) {
            //            alert("The password is reset successfully and sent to you account e-mail.");
            //        } else {
            //            return;
            //        }
            //});
    /**End of  Forgot password Alert **/

    /** Start of registration Button **/

            //$(document).on("click","#regBtn",function(){
            
            //    $("#login").modal("hide");
            //    $("a[data-target='#register']").trigger('click');
            //});
            
            
            
            
             //$(document).on("click","#registerBtn",function(){
        
                   
             //      console.log("in submit login");
             //      var regemail = $("#register").find("#email").val();
             //      var regpassword = $("#register").find("#regUsername").val();
             //      var regfirstname = $("#register").find("#regFirstname").val(); ;
             //      var reglastname = $("#register").find("#regLastname").val();;
             //      var regcontact = $("#register").find("#regcontact").val();;
             //      var regusername =$("#register").find("#regUsername").val();
             //      var regcpswd = $("#register").find("#regConfrimPass").val();
                   
             //      console.log(regcontact +" "+regemail+""+regfirstname+""+regusername+""+regcontact);
                    
             //       if(regcpswd != regcpswd){
             //           alert("Password and Confirm Password does not match.");
             //           return;
             //       }
             //           alert("Your Registration is successful.Gift Card worth $50 has been sent to "+regemail);
             //           $("#register").modal("hide");
             //           $.cookie("username",regusername,{path:'/'});
             //           $.cookie("email",regemail,{path:'/'});
             //           $.cookie("firstname",regfirstname,{path:'/'});
             //           $.cookie("lastname",reglastname,{path:'/'});
             //           $.cookie("contact",regcontact,{path:'/'});
                        
             //           $("#myaccount").show();
             //           $("#loginlinks").hide();
             //           name = $.cookie("username");
             //           $("#username").html(name);
                        
                        
             //          });
    /** End registration Button **/


    /** Start of Logout **/

           //$("#logout").click(function(){
           //     console.log("in logout");
           //     $.removeCookie('username',{path:'/'});
           //     $.removeCookie('email',{path:'/'});
           //     $.removeCookie('firstname',{path:'/'});
           //     $.removeCookie('lastname',{path:'/'});
           //     $.removeCookie('contact',{path:'/'});
                
           

           //     $("#myaccount").hide();
           //     $("#loginlinks").show();
           //     $("#username").html(" ");
           //});


    /** End of Logout **/
});




