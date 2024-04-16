const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Enter the first number: ', (firstNumber) => {
  rl.question('Enter the operator (+, -, *, /): ', (operator) => {
    rl.question('Enter the second number: ', (secondNumber) => {
      let result;

      firstNumber = Number(firstNumber);
      secondNumber = Number(secondNumber);

      switch (operator) {
        case '+':
          result = firstNumber + secondNumber;
          break;
        case '-':
          result = firstNumber - secondNumber;
          break;
        case '*':
          result = firstNumber * secondNumber;
          break;
        case '/':
          if (secondNumber !== 0) {
            result = firstNumber / secondNumber;
          } else {
            console.log('Error! Division by zero is not allowed.');
            rl.close();
            return;
          }
          break;
        default:
          console.log(`Error! Invalid operator ${operator}.`);
          rl.close();
          return;
      }

      console.log(`The result is: ${result}`);
      rl.close();
    });
  });
});