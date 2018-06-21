use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_PAISES(
	ID_PAIS int auto_increment not null,
    NOME_PAIS varchar(100) not null,
    DDI int not null,
    primary key(ID_PAIS)
);