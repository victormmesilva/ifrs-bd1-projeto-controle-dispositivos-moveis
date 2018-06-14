use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_MODELOS_DE_CELULAR(
	ID_MODELO int auto_increment not null,
    NOME_MODELO varchar(100) not null,
    NUMERO_CHIP int not null,
    FK_ID_MARCA_CELULAR int not null,
    FK_ID_TIPO_CHIP int not null,
    primary key(ID_MODELO),
    foreign key(FK_ID_MARCA_CELULAR) references TBT_MARCAS_DE_CELULAR(ID_MARCA),
    foreign key(FK_ID_TIPO_CHIP) references TBT_TIPOS_DE_CHIP(ID_TIPO_CHIP)    
);
