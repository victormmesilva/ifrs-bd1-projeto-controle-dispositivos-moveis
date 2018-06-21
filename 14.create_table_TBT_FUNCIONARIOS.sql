use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_FUNCIONARIOS(
	ID_FUNCIONARIO int auto_increment not null,
    CPF int(11) unique not null,
    RG int(10) unique not null,
    NOME_COMPLETO varchar(150) not null,
    DATA_NASCIMENTO date not null,
    TELEFONE int not null,
    NOME_DA_MAE varchar(150) not null,
    FK_ID_CARGO int not null,
    FK_ID_GENERO int not null,
    FK_ID_RUA int not null,
    primary key(ID_FUNCIONARIO),
    foreign key(FK_ID_CARGO) 	references TBT_CARGOS(ID_CARGO),
    foreign key(FK_ID_GENERO) 	references TBT_GENEROS(ID_GENERO),
    foreign key(FK_ID_RUA) 		references TBT_RUAS(ID_RUA)
);
