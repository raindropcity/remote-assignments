function countAandB(input) {
  let count = 0
  input.forEach((element) => {
    if (element === 'a' || element === 'b') count++
  })

  return count
}

function toNumber(input) {
  const alphabetArray = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
  const toNumberArray = []
  input.forEach((element) => {
    toNumberArray.push(alphabetArray.indexOf(element) + 1)
  })

  return toNumberArray
}
