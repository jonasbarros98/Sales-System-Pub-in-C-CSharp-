create database bd_crud;
use bd_crud;

create table dados(
	cd_dados int auto_increment,
    nm_nome varchar(60) not null,
   dadosusuarios sg_estado varchar(2) not null,
    nm_cidade varchar(30) not null,
    ds_endereco varchar(100) not null,
    primary key (cd_dados)
);


insert into dados (cd_dados, nm_nome, sg_estado,nm_cidade,ds_endereco) 
values (null,'Jonas','GO','Rio Verde','Rua dos Carajas');
select * from usudadosarios;

insert into usuarios (id_login,login,senha) values (null,"jonas","12345");

select nm_nome, sg_estado, nm_cidade, ds_endereco from dados where cd_dados = 1;

update dados set nm_nome = "Jonas Barros",sg_estado = "RJ", nm_cidade = "Rio de Janeiro",ds_endereco = "Rua das quantas" where cd_dados = 1;

create table usuarios(
id_login int auto_increment,
login varchar(60) not null,
senha varchar(60) not null,
primary key (id_login));


select * from dados;

select * from usuarios;

alter table dados add column categoria_fornec VARCHAR(40);

