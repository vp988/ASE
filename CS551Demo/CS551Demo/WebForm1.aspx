<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CS551Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type='text/javascript' src='http://code.jquery.com/jquery-1.8.3.js'></script>
    <script type = "text/javascript">
        function wscall() {
            var name = document.getElementById("uname");
           // alert(name.value);
            var data1 = name.value;
            $.get("http://localhost:60574/Service1.svc/data/"+data1, function (data) {
                    
                $("#formdiv").html(data);
            });

           /* window.location.href="http://localhost:60574/Service1.svc/data/"+data;*/
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="formdiv">
    <label for="username">UserName:</label>
      <input type="text" id="uname" size="30" />
        <br />
        <label for="Pwd">Password:</label>
      <input type="password" id="pwd" size="30" />
      <br />
     <input type ="button"  value="Login" onclick="wscall()"/>
    </div>
    </form>
</body>
</html>