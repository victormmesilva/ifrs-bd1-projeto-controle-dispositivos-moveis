use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_BAIRROS(
	ID_BAIRRO int auto_increment not null,
    NOME_BAIRRO varchar(100) not null,    
    FK_ID_CIDADE int not null,
    primary key(ID_BAIRRO),
    foreign key(FK_ID_CIDADE) references TBT_CIDADES(ID_CIDADE)
);