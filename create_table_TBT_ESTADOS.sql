use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_ESTADOS(
	ID_ESTADO int auto_increment not null,
    NOME_ESTADO varchar(100) not null,
    SIGLA_ESTADO varchar(2) not null,
    FK_ID_PAIS int not null,
    primary key(ID_ESTADO),
    foreign key(FK_ID_PAIS) references TBT_PAISES(ID_PAIS)
);