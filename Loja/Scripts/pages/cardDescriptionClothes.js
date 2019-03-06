
function carregaMais() {
    $.ajax({

        url: 'http://localhost:10092/produtos/',
        type: 'GET',
        data: { 'CardMomdel': ProductList },
        datatype: 'json',

        success: function (json) {
            alert(json);
        }
    }); 
}
