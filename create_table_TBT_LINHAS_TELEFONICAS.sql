use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_LINHAS_TELEFONICAS(
	ID_LINHA int auto_increment not null,
    NUMERO_TELEFONE int not null,
    FK_ID_DDD int not null,
    FK_ID_DDI int not null,
    FK_ID_OPERADORA int not null,
    primary key(ID_LINHA),
    foreign key(FK_ID_DDD) references TBT_DDD_CIDADES(ID_DDD),
    foreign key(FK_DDI) references TBT_PAISES(DDI),
    foreign key(FK_ID_OPERADORA) references TBT_OPERADORAS_TELEFONICAS(ID_OPERADORA)
);