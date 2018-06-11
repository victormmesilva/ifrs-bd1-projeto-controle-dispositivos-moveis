use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_CIDADES(
	ID_CIDADE int auto_increment not null,
    NOME_CIDADE varchar(100),
    FK_ID_ESTADO int not null,
    DDD int not null,
    primary key(ID_CIDADE),
    foreign key(FK_ID_ESTADO) references TBT_ESTADOS(ID_ESTADO)
);