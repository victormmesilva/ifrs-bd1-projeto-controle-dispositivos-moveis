use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_CIDADES(
	ID_CIDADE int auto_increment not null,
    NOME_CIDADE varchar(100),
    DDD int not null,
    primary key(ID_CIDADE)
);