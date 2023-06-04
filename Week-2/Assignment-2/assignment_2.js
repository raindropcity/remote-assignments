function avg(data) {
  let totalPrice = 0
  for (let i = 0; i < data.products.length; i++) {
    totalPrice = totalPrice + data.products[i].price
  }
  return (totalPrice / data.size)
}
