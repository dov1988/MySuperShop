﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MVC.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <div class="form">
        <form id="form1" runat="server" enctype="multipart/form-data">
            <h3>Данные покупателя</h3>
            <div class="data">
                <div>
                    <label>Имя</label>
                    <input name="FirstName" />
                </div>
                 <div>
                    <label>Отчество</label>
                    <input name="MiddleName" />
                </div>
                 <div>
                    <label>Фамилия</label>
                    <input name="LastName" />
                </div>
                 <div>
                    <label>Телефон</label>
                    <input name="Phone" />
                </div>
                <div>
                    <label>Email</label>
                    <input name="Email" />
                </div>
                <input type="submit" value="Вставить в БД" />
            </div>
        </form>
    </div>

    <style>
        .form { position: absolute; left: 50%; width: 470px; margin-left: -235px; background: #888; border-radius: 5px; top: 20px; }
        form { background: #fff; border-radius: 2px;  margin: 5px;  }
        .data { border-top: 1px solid #d5d5d5; padding: 10px 15px; }
        .data div { margin: 8px 0; }
        h3 { padding: 10px 15px; margin: 0; }
        label { min-width: 100px; display: block; float: left; }
        input[type="submit"] { margin-top: 10px; }
    </style>
</body>
</html>
