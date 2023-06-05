function count(input) {
  const output = {}
  const en = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
  for (let i = 0; i < en.length; i++) {
    const countArr = input.filter((element) => element === en[i])
    if (countArr.length) output[en[i]] = countArr.length
  }
  return output
}

function groupByKey(input) {
  const output = {}
  input.forEach((element) => {
    const exsitedKey = Object.keys(output)
    if (exsitedKey.includes(element.key)) element.value += output[element.key]
    output[element.key] = element.value
  })
  return output
}
