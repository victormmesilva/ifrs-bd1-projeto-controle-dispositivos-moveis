use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_RUAS(
	ID_RUA int auto_increment not null,
    NOME_RUA varchar(100) not null,    
    FK_ID_BAIRRO int not null,
    primary key(ID_RUA),
    foreign key(FK_ID_BAIRRO) references TBT_BAIRROS(ID_BAIRRO)
);