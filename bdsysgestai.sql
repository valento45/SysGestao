CREATE DATABASE sysgestao
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;
	
	drop table sysgestao.tb_produto
	
	create table sysgestao.tb_produto(
	id_produto serial not null primary key,
	codigo_sku varchar(150)not  null,
	cor varchar(100) null,
	tamanho varchar(10)	 null,
	quantidade integer not null default 0,
	variacao varchar(100) not null,
    descricao varchar(200) null,
	codigo_barras varchar,
	imagem_base64 varchar,
		codigo_barras_texto varchar
	);
	
	select * from sysgestao.tb_solicitacao_produto
	drop table sysgestao.tb_solicitacao_produto
		
	create table sysgestao.tb_solicitacao_produto(
	id_solicitacao serial not null primary key,
	nome_destinatario varchar(200) not null,
	status varchar(50) not null,
	data_solicitacao timestamp,
	arquivo_origem varchar
	);
	
	select * from sysgestao.tb_item_solicitacao
	drop table sysgestao.tb_item_solicitacao
	create table sysgestao.tb_item_solicitacao(
	id_item serial not null primary key,
	id_solicitacao integer not null,
	id_produto integer not null,
	quantidade integer not null,
	constraint id_solicitacao_fk foreign key  (id_solicitacao)
	references sysgestao.tb_solicitacao_produto(id_solicitacao),
	constraint id_produto_fk foreign key  (id_produto)
	references sysgestao.tb_produto(id_produto)
	);
	---------------------------------------------------------------------
	select * from sysgestao.tb_pre_solicitacao_produto
create table sysgestao.tb_pre_solicitacao_produto(
	id_pre_solicitacao serial not null primary key,
	nome_destinatario varchar(200) not null,
	arquivo_origem varchar
	);
	
	drop table sysgestao.tb_item_pre_solicitacao
	
	select * from sysgestao.tb_item_pre_solicitacao
		create table sysgestao.tb_item_pre_solicitacao(
			id_item serial not null primary key,
			id_pre_solicitacao integer not null,			
			codigo_sku varchar not null,
			variacao varchar not null,
			quantidade integer not null,
	constraint id_pre_solicitacao_fk foreign key  (id_pre_solicitacao)
	references sysgestao.tb_pre_solicitacao_produto(id_pre_solicitacao)
	);
	
	
	
	

	