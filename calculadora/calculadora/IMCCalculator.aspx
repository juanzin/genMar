<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IMCCalculator.aspx.cs" Inherits="calculadora.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>IMC Calculator</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>

<div class="container">
    <form action="calculadora.asmx/calculateIMC" method="post">
        <div class="card">
            <h1>Calculate Your BMI</h1>

            <div class="input-group">
                <label>Weight (kg)</label>
                <input name="peso" type="number" placeholder="Enter your weight">
            </div>

            <div class="input-group">
                <label>Height (m)</label>
                <input name="altura" type="number" step="0.01" placeholder="Enter your height">
            </div>

            <button type="submit">Calculate</button>

            <%--<div class="result">
                <p>Your BMI:</p>
                <h2>--</h2>
                <span class="status">---</span>
            </div>--%>
        </div>
    </form>
</div>

</body>
</html>