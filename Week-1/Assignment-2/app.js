const welcome = document.querySelector('.welcome')
const button = document.querySelector('.btn')
const addSection = document.querySelector('.add-section')

welcome.addEventListener('click', () => {
  welcome.children[0].textContent = 'Have a Good Time!'
})

button.addEventListener('click', () => {
  addSection.style.display = 'block'
})