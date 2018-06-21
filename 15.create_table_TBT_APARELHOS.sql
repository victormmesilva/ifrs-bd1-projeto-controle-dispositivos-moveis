use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS;
create table TBT_APARELHOS(
	ID_APARELHO int auto_increment not null,
    SENHA_APARELHO varchar(50) not null,
    IMEI int not null,
    NUMERO_DE_SERIE int not null,
    MAC_ADDRESS varchar(12),
    FK_ID_MODELO int not null,
    FK_ID_LINHA int not null,
    FK_ID_FUNCIONARIO int,
    primary key(ID_APARELHO),
    foreign key(FK_ID_MODELO) references TBT_MODELOS_DE_CELULAR(ID_MODELO),
    foreign key(FK_ID_LINHA) references TBT_LINHAS_TELEFONICAS(ID_LINHA),
    foreign key(FK_ID_FUNCIONARIO) references TBT_FUNCIONARIOS(ID_FUNCIONARIO)
);