function max(numbers) {
  let maxNum = numbers[0]
  for (let i = 1; i <= numbers.length; i++) {
    if (numbers[i] > maxNum) maxNum = numbers[i]
  }
  return maxNum
}

function findPosition(numbers, target) {
  if (!numbers.some((element) => element === target)) return -1
  for (let i = 0; i <= numbers.length; i++) {
    if (numbers[i] === target) return i
  }
}
