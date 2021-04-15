# ProjetBackEnd

Alterar a connectionstring para a pasta local do projeto. Criar uma base mdf do mesmo nome, na pasta do caminho, as tabelas serão geradas automaticamente. 

Segue abaixo um exemplo do body do json para salvar o pedido.

{
    "Data" : "2020-10-13",
    "Pizza" : [{
        "TipoPizza" : {
            "Id" : "9c598b81-0792-4294-9e71-44ba637a081d",
            "Tipo" : "Três Queijos",
            "Preco" : 50.0
        },
        "Porcao" : {
            "Id" : "0f516348-7ffb-4103-9e62-a930e9fd2277",
            "Tipo" : 1
        }
    }],
    "Cliente" : {
            "Id" : "00000000-0000-0000-0000-000000000000",
            "Nome" : "Cliente",
            "Endereco" : {
                "Id" : "00000000-0000-0000-0000-000000000000",
                "Logradouro" : "Rua x",
                "Cep" : "000",
                "Cidade" : "Sp",
                "Estado" : "Sp"
            }
        }
}
