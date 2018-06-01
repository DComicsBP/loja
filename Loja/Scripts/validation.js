function validateEmail() {
    var docEmail = document.getElementById('email');
    var value = docEmail.value;

    if (value.includes("@") === false) {
        alert("Você nao forneceu um email válido!!!");
        return false;
    }
    if (value.length < 5) {
        alert('Você não forneceu um email');
        return false;
    }
    if (value.includes(" ") === true) {
        alert('Você não colocou um email válido!'); 
    }
    if (value.toArray())
    return value.includes("@");
}


function validateName() {
    var docName = document.getElementById('name');
    var value = docName.value; 

    if (value.length < 3) {
        alert("Nome inválido!!")
        return false;
    } else if (value === 'null') {
        alert('Você não forneceu um nome!')
        return false;
    } else if (typeof value === 'undefined') {
        alert('Você não forneceu algo'); 
        return false; 
    }
    return true;

}
function validate() {   
    if (validateEmail() === false)
        return false;
    if (validateName() === false)
        return false; 
    return true; 
}
