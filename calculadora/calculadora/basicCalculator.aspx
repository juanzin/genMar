<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="basicCalculator.aspx.cs" Inherits="calculadora.basicCalculator" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Simple Calculator</title>
    <link rel="stylesheet" href="styles.css">
    <script>
        function calcular(operacion) {
            let num1 = document.getElementById("num1").value;
            let num2 = document.getElementById("num2").value;

            let url = `https://localhost:44316/calculadora.asmx/${operacion}?numero1=${num1}&numero2=${num2}`;

            fetch(url, {
                     method: "GET" 
                })
                .then(response => response.text())
                .then(data => {
                    // extract result from XML
                    let result = data.match(/>(.*?)</)[1];
                    document.getElementById("resultado").innerText = result;
                })
                .catch(error => {
                    console.error(error);
                    document.getElementById("resultado").innerText = "Error";
                });
        }
    </script>
</head>
<body>
    <form>
        <div class="calculator">
            <h2>Calculator</h2>

            <input type="number" id="num1" placeholder="First number">
            <input type="number" id="num2" placeholder="Second number">

            <div class="buttons">
                <button onclick="calcular('suma')">+</button>
                <button onclick="calcular('resta')">-</button>
                <button onclick="calcular('multiplicacion')">*</button>
                <button onclick="calcular('division')">/</button>
            </div>

            <h3 id="resultado">Result: <span>--</span></h3>
        </div>
    </form>
</body>
</html>
