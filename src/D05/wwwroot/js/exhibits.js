/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}

$(document).ready(function(){
    
    var name = $.cookie("username");
    console.log("in home"+$.cookie("username"));
    
     if(name == "null" || name == undefined){
            console.log("in if");
            $("#myaccount").hide();
            $("#loginlinks").show();
            $("#username").html(" ");
     }else{
            console.log("in else");
            $("#myaccount").show();
            $("#loginlinks").hide();
            $("#username").html(name);   
     }
     
     /* start of on click of links in homepage for exhibits tab**/
    var targetTab = getParameterByName('tab');
    console.log("tabname"+targetTab);
        if(targetTab === 'exone'){
                $("#exonetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exonetarget").show();
        }
        if(targetTab === 'extwo'){
            $("#extwotab").addClass('active');
                $("#exonetab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#exonetarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#extwotarget").show();
        }
        if(targetTab === 'exthree'){
                $("#exthreetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exonetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exthreetarget").show();
        }
        if(targetTab === 'exfour'){
                $("#exfourtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exonetarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfourtarget").show();
        }
        if(targetTab === 'exfive'){
                $("#exfivetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfivetarget").show();
        }
        if(targetTab === 'exsix'){
            $("#exsixtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").hide();
                $("#exsixtarget").show();
        }
        if(targetTab === 'exseven'){
            $("#exseventab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exonetab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").show();
        }
     /* end of on click of links in homepage for exhibits tab**/
     
     
     
    /* start of on click of menu in exhibits page**/
    $("#exonelink").click(function(){
                $("#exonetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exonetarget").show();
          });
          
          $("#extwolink").click(function(){
                $("#extwotab").addClass('active');
                $("#exonetab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#exonetarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#extwotarget").show();
          });
          
          $("#exthreelink").click(function(){
                $("#exthreetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exonetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exthreetarget").show();
          });
          
          $("#exfourlink").click(function(){
                $("#exfourtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exonetarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfourtarget").show();
          });
          
          $("#exfivelink").click(function(){
                $("#exfivetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfivetarget").show();
          });
          
          $("#exsixlink").click(function(){
                $("#exsixtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").hide();
                $("#exsixtarget").show();
          });
          
           $("#exsevenlink").click(function(){
                $("#exseventab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exonetab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").show();
                
          });
          
    /* end of on click of menu in exhibits page**/
    
    /** start- for click on left menu tabs in exhibits page **/
          $("#exonetab").click(function(){
                $("#exone").addClass('active');
                $("#extwo").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exonetarget").show();
          });
          
          $("#extwotab").click(function(){
                $("#extwo").addClass('active');
                $("#exone").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#exonetarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#extwotarget").show();
          });
          
          $("#exthreetab").click(function(){
                $("#exthree").addClass('active');
                $("#extwo").removeClass('active');
                $("#exone").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exonetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exthreetarget").show();
          });
          
          $("#exfourtab").click(function(){
                $("#exfour").addClass('active');
                $("#extwo").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exone").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exonetarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exfourtarget").show();
          });
          
          $("#exfivetab").click(function(){
                $("#exfive").addClass('active');
                $("#extwo").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exone").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").hide();
                $("#exfivetarget").show();
          });
          
          $("#exsixtab").click(function(){
                $("#exsix").addClass('active');
                $("#extwo").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exone").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").show();
                
          });
          
          $("#exseventab").click(function(){
                $("#exseven").addClass('active');
                $("#extwo").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exone").removeClass('active');
                
                $("#exonetarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").show();
                
          });
          
    /** end- for click on left menu tabs in exhibits page **/
    
    
    /** login and savong data to cookies**/
   
   $(document).on("click","#lgnbtn",function(){
        
                   
                   console.log("in submit login");
                   var username = $("#login").find("#user").val();
                   var password = $("#login").find("#password").val();
               
               $.each(user, function(a, b) {
                if (username === b.username || username === b.email) {
                    console.log(b.username);
                    console.log(b.password);
                    if (password === b.password) {
                      console.log("in password");
                        $.cookie("username", b.username,{path:'/'});
                        $.cookie("email", b.email,{path:'/'});
                        $.cookie("firstname", b.firstname,{path:'/'});
                        $.cookie("lastname", b.lastname,{path:'/'});
                        $.cookie("contact", b.contact,{path:'/'});
                        $("#login").modal("hide");
                        
                       /** setTimeout(function() {
                            window.location.href = window.location.origin + window.location.pathname;
                        }, 500);
                        removeOverlay();**/
                        $("#myaccount").show();
                        $("#loginlinks").hide();
                        name = $.cookie("username");
                        $("#username").html(name);
                        return;
                    } else {
                        alert("please enter the password correctly");
                    }
                }
            });
            
            if (!$.cookie("username")) {
                alert("Invalid username or password. Please try again.");
            }
            
            });
            
            $(document).on("click","#forgotPassword",function(){
            
                var fgt = prompt("Please enter the e-mail address of your account");
                    if (fgt) {
                        alert("The password is reset successfully and sent to you account e-mail.");
                    } else {
                        return;
                    }
            });
            
            $(document).on("click","#regBtn",function(){
            
                $("#login").modal("hide");
                $("a[data-target='#register']").trigger('click');
            });
            
            /** end of login and cookies **/
    
            $(document).on("click","#registerBtn",function(){
        
                   
                   console.log("in submit login");
                   var regemail = $("#register").find("#email").val();
                   var regpassword = $("#register").find("#regUsername").val();
                   var regfirstname = $("#register").find("#regFirstname").val(); ;
                   var reglastname = $("#register").find("#regLastname").val();;
                   var regcontact = $("#register").find("#regcontact").val();;
                   var regusername =$("#register").find("#regUsername").val();
                   var regcpswd = $("#register").find("#regConfrimPass").val();
                   
                   console.log(regcontact +" "+regemail+""+regfirstname+""+regusername+""+regcontact);
                    
                    if(regcpswd != regcpswd){
                        alert("Password and Confirm Password does not match.");
                        return;
                    }
                        alert("Your Registration is successful.Gift Card worth $50 has been sent to "+regemail);
                        $("#register").modal("hide");
                        $.cookie("username",regusername,{path:'/'});
                        $.cookie("email",regemail,{path:'/'});
                        $.cookie("firstname",regfirstname,{path:'/'});
                        $.cookie("lastname",reglastname,{path:'/'});
                        $.cookie("contact",regcontact,{path:'/'});
                        
                        $("#myaccount").show();
                        $("#loginlinks").hide();
                        name = $.cookie("username");
                        $("#username").html(name);
                        
                       });
    
    $("#logout").click(function(){
                console.log("in logout");
                $.removeCookie('username',{path:'/'});
                $.removeCookie('email',{path:'/'});
                $.removeCookie('firstname',{path:'/'});
                $.removeCookie('lastname',{path:'/'});
                $.removeCookie('contact',{path:'/'});
                
           

                $("#myaccount").hide();
                $("#loginlinks").show();
                $("#username").html(" ");
            });
    
});

