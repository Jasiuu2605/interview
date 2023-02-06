const readline = require("readline");
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout,
});

rl.question("Enter N: ", (nStr) => {
  const n = parseInt(nStr);
  rl.question("Enter the array of integers: ", (arrayStr) => {
    const array = arrayStr.split(" ").map((numStr) => parseInt(numStr));
    const count = Array(10).fill(0);
    for (const num of array) {
      let temp = num;
      while (temp > 0) {
        const digit = temp % 10;
        count[digit]++;
        temp = Math.floor(temp / 10);
      }
    }
    let maxDigit = 0;
    for (let i = 9; i >= 1; i--) {
      if (count[i] > count[maxDigit]) {
        maxDigit = i;
      }
    }
    console.log(maxDigit);
    rl.close();
  });
});
