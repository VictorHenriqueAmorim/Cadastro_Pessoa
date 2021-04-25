function ceprequest() {
    return new Promise((resolve, reject) => {
        let cep = $("#cep").val()
        $.ajax({
            url: `https://viacep.com.br/ws/${cep}/json/`,
            type: 'GET',
            data: "",
            success: function (data) {
                resolve(data)
            },
            error: function (error) {
                reject(error)
            },
        })
    })
}
function getcep() {
    if ($("#cep").val().length != 8) return alert("CEP Invalido!");
    ceprequest().then((x) => {
        $("#logradouro").val(x.logradouro);
        $("#complemento").val(x.complemento);
        $("#bairro").val(x.bairro);
        $("#cidade").val(x.localidade);
        $("#uf").val(x.uf);
    });
}
function format(x, type) {
    let value = x.value;
    if (isNaN(value[value.length - 1])) {
        x.value = value.substring(0, value.length - 1);
        return;
    }

    switch (type) {
        case "cpf":
            x.setAttribute("maxlength", "14");
            if (value.length == 3 || value.length == 7) x.value += ".";
            if (value.length == 11) x.value += "-";
            break;
        case "cnpj":
            x.setAttribute("maxlength", "18");
            if (value.length == 2 || value.length == 6) x.value += ".";
            if (value.length == 10) x.value += "/";
            if (value.length == 15) x.value += "-";
            break;
    }
}
function validation(type) {
    switch (type) {
        case "cpf":
            if ($("#cpf").val().length != 14) return alert("CPF Invalido!");
            break;
        case "cnpj":
            if ($("#cnpj").val().length != 18) return alert("CNPJ Invalido!");
            break;
        case "idade":
            let date = new Date($('#datadenascimento').val()).getFullYear();
            let datenow = new Date(Date.now()).getFullYear();
            if ((datenow - date) < 19) {
                $('#datadenascimento').val("");
                return alert("Cadastro de pessoa física permitida apenas para maiores de 18 anos.");
            }
            break;
    }
}
function buttonAction(x) {

    switch (x) {
        case "pf":
            $("#tipopessoa").removeClass("d-flex").addClass("d-none");
            $("#formcadastro").removeClass("d-none").addClass("d-flex");
            $("#pessoajuridica").addClass("d-none");
            $("#pessoafisica").removeClass("d-none");
            $("#pessoajuridica input").removeAttr("required");
            $("#pessoafisica input").attr("required", true);
            break;

        case "pj":
            $("#tipopessoa").removeClass("d-flex").addClass("d-none");
            $("#formcadastro").removeClass("d-none").addClass("d-flex");
            $("#pessoafisica").addClass("d-none");
            $("#pessoajuridica").removeClass("d-none");
            $("#pessoafisica input").removeAttr("required");
            $("#pessoajuridica input").attr("required", true);
            $("#formcadastro input").val("");
            break;

        case "voltar":
            $("#formcadastro").removeClass("d-flex").addClass("d-none");
            $("#tipopessoa").removeClass("d-none").addClass("d-flex");
            $("#formcadastro input").val("");
            break;
    }
}
function save() {
    $.ajax({
        type: "POST",
        url: "/Cadastro/Post",
        data: $("#dados").serializeArray(),
        success: function () {

        },
        error: function () {

        }
    });
}