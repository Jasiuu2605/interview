const readline = require("readline");
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

rl.question("Enter N: ", (nStr) => {
  const n = parseInt(nStr);
  rl.question("Enter the array of integers: ", (arrayStr) => {
    const array = arrayStr.split(" ").map((numStr) => parseInt(numStr));
    let maxSum = 0;
    let maxIndex = 0;
    for (let i = 0; i < n; i++) {
      const num = array[i];
      let sum = 0;
      let temp = num;
      while (temp > 0) {
        sum += temp % 10;
        temp = Math.floor(temp / 10);
      }
      if (sum > maxSum || (sum === maxSum && i > maxIndex)) {
        maxSum = sum;
        maxIndex = i;
      }
    }
    console.log(maxIndex);
    rl.close();
  });
});
