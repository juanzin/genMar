// document.getElementById('convertButton').addEventListener('click', async function() {
//   const API_KEY = 'f8b9ca5879111e54f4a3368c';
//   const amount = document.getElementById('amount').value;
//   const currencyFrom = document.getElementById('currencyFrom').value;
//   const currencyTo = document.getElementById('currencyTo').value;
//   const resultDiv = document.getElementById('result');

//   //JQUERY
//   $("#convertButton").slideUp(3000).delay(8000).fadeIn(4000);

//   if (!amount || isNaN(amount)) {
//     resultDiv.textContent = 'Por favor, ingresa un valor válido';
//     return;
//   }

//   const API_URL = `https://v6.exchangerate-api.com/v6/${API_KEY}/latest/${currencyFrom}`;

//   try {
//     const response = await fetch(API_URL);
//     const data = await response.json();

//     if (data.result === 'success') {
//       const rate = data.conversion_rates[currencyTo];
//       const convertedAmount = (amount * rate).toFixed(2);
//       resultDiv.textContent = `${amount} ${currencyFrom} = ${convertedAmount} ${currencyTo}`;
//     } else {
//       resultDiv.textContent = 'Error al obtener las tasas de cambio.';
//     }
//   } catch (error) {
//     resultDiv.textContent = 'Error al conectar con la API.';
//   }
// });
// var moneyFrom;
// var moneyTo;
// var amount;

async function getExchangeData(_amount, _currencyFrom, _currencyTo) {
	const API_KEY = 'f8b9ca5879111e54f4a3368c';
	const API_URL = `https://v6.exchangerate-api.com/v6/${API_KEY}/latest/${_currencyFrom}`;

	try {
		var response = await fetch(API_URL);
		var data = await response.json();

		if (data.result === 'success') {
			var rate = data.conversion_rates[_currencyTo];
			var convertedAmount = (_amount * rate).toFixed(2);
			displayExchange(_amount, convertedAmount, _currencyFrom, _currencyTo);
		} else {
			displayError();
			// resultDiv.textContent = 'Error al obtener las tasas de cambio.';
		}
	} catch (error) {
			displayError();
		// resultDiv.textContent = 'Error al conectar con la API.';
	}

}

function convertMoney(){
	// var currencyFrom = 'USD';
	// var currencyTo = 'USD';
	// var amount = $('#amount').val();
	/// obtener tipo seleccionado
	var moneyFrom =  $('#currencyFrom').val();
	var moneyTo =  $('#currencyTo').val();
	var amount = $('#amount').val();
	getExchangeData(amount, moneyFrom, moneyTo);
}

function displayExchange(_amount, _value, _currencyFrom, _currencyTo) {
	text = `${_amount} ${_currencyFrom} = ${_value} ${_currencyTo}`;
	$('#result').text(text);
}

function displayError() {
	$('#result').text('No converted');
}

function InitTypesMoney() {
	const money = [
		{
			key: 'USD',
			value: 'Dólar Estadounidense'
		},
		{
			key: 'EUR',
			value: 'Euro'
		},
		{
			key: 'GBP',
			value: 'Libra Esterlina'
		},
		{
			key: 'JPY',
			value: 'Yen Japonés'
		},
		{
			key: 'MXN',
			value: 'Peso Mexicano'
		},
		{
			key: 'ARS',
			value: 'Peso Argentino'
		},
		{
			key: 'CAD',
			value: 'Dólar Canadiense'
		},
		{
			key: 'PYG',
			value: 'Guaraní Paraguayo'
		}
	];

	$.each(money, function(i, item) {
    	$('#currencyFrom').append($('<option>', { 
        	value: item.key,
        	text : item.value 
    	}));

		$('#currencyTo').append($('<option>', { 
        	value: item.key,
        	text : item.value 
    	}));
	});
}

function swapTypeMoney() {
	var moneyFrom = $('#currencyFrom').val();
	var moneyTo = $('#currencyTo').val();

   $('#currencyFrom').val(moneyTo);
   $('#currencyTo').val(moneyFrom);

   convertMoney();
}

async function init() {
	InitTypesMoney();
}



window.addEventListener('DOMContentLoaded', (event) => {
	init();

	$('#convertButton').on('click', function() {
    	convertMoney();
	});

	$('#arrows').on('click', function() {
    	swapTypeMoney();
	});
});










