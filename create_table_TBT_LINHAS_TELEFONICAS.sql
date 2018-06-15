use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_LINHAS_TELEFONICAS(
	ID_LINHA int auto_increment not null,
    NUMERO_TELEFONE int not null,
    FK_ID_CIDADE int not null,
    FK_ID_PAIS int not null,
    FK_ID_OPERADORA int not null,
    primary key(ID_LINHA),
    foreign key(FK_ID_CIDADE) references TBT_CIDADES(ID_CIDADE),
    foreign key(FK_ID_PAIS) references TBT_PAISES(ID_PAIS),
    foreign key(FK_ID_OPERADORA) references TBT_OPERADORAS_TELEFONICAS(ID_OPERADORA)
);