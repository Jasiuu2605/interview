function optionalPow(a, b) {
  const confirmMessage = "Do you agree to make the calculation?";
  const agree = confirm(confirmMessage);
  return agree ? Math.pow(a, b) : Math.pow(b, a);
}

console.log(optionalPow(3, 2));

function fixAge(ages) {
  const filtered = ages.filter((age) => age >= 18 && age <= 60);
  return filtered.length > 0 ? filtered.join(",") : "NA";
}

console.log(fixAge([5, 15, 25, 78, 59, 45]));
console.log(fixAge([18, 3, 30, 22, 11, 60]));
console.log(fixAge([1, 3, 3, 2, 11, 6]));








