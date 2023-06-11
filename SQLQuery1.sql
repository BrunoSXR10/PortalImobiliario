create table tb_endereco  
( 
 ID_endereco int not null, 
 numero int not null, 
 logradoro varchar(10) not null, 
 complemento varchar(30), 
 cep int not null,  
);

alter table tb_endereco add constraint pk_endereco primary key (ID_endereco);


create table tb_corretor 
( 
 ID_corretor int not null,  
 nome varchar(70) not null, 
 senha varchar(15) not null, 
 cpf int not null, 
 dt_nascimento date not null, 
 deputado varchar(15) 
);

alter table tb_corretor add constraint pk_corretor primary key (ID_corretor);


create table tb_imovel
( 
 ID_imovel int not null,  
 Descricao varchar(150) not null, 
 valor float not null, 
 ID_endereco int not null,
 ID_corretor int not null
);

alter table tb_imovel add constraint pk_imovel primary key (ID_imovel);


alter table tb_imovel add constraint fk_imovel_endereco foreign key (ID_endereco) references tb_endereco(ID_endereco);
alter table tb_imovel add constraint fk_imovel_ccorretor foreign key (ID_corretor) references tb_corretor(ID_corretor);
