const form = document.getElementById('form')
const checkbox = document.getElementById('checkboxV')
const message = document.getElementById('message')

form.addEventListener('submit', function validateCheckbox(e) {
    e.preventDefault()
    if (checkbox.checked === true) {
        message.innerHTML = 'Done'
    }
    else {
        message.innerHTML = 'Please agree to the Terms'
    }
})