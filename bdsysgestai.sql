

CREATE DATABASE sysgestao
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    CONNECTION LIMIT = -1;	
	
	create table sysgestao.tb_usuario(
	id_usuario serial not null primary key,
		nome varchar not null,
		user_name varchar(100) unique not null,
		senha varchar not null,
		pergunta_secreta varchar,
		resposta_secreta varchar
	);	
	
	create table sysgestao.tb_login(
		id_login serial not null primary key,
		id_usuario integer not null,
		data_hora timestamp not null	,
		tipo integer not null
	);
	
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
	
		
	create table sysgestao.tb_solicitacao_produto(
	id_solicitacao serial not null primary key,
	nome_destinatario varchar(200) not null,
	status varchar(50) not null,
	data_solicitacao timestamp,
	arquivo_origem varchar
	);
	

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
drop table sysgestao.tb_pre_solicitacao_produto

	create table sysgestao.tb_pre_solicitacao_produto(
	id_pre_solicitacao serial not null primary key,
	nome_destinatario varchar(200) not null,
	arquivo_origem varchar,
	data_solicitacao timestamp
	);
	
	alter table sysgestao.tb_pre_solicitacao_produto ADD COLUMN data_solicitacao timestamp;
	

drop table sysgestao.tb_item_pre_solicitacao

		create table sysgestao.tb_item_pre_solicitacao(
			id_item serial not null primary key,
			id_pre_solicitacao integer not null,			
			codigo_sku varchar not null,
			variacao varchar not null,
			quantidade integer not null,
	constraint id_pre_solicitacao_fk foreign key  (id_pre_solicitacao)
	references sysgestao.tb_pre_solicitacao_produto(id_pre_solicitacao)
	);

create table sysgestao.tb_campos_xls(
	id_campo serial not null primary key,
	nome varchar not null,
	mask boolean null,
	obrigatorio boolean,
	conteudo varchar null,
	tipo integer null,
	readonly boolean null
);
	


---VERSION 3.0
alter table if exists sysgestao.tb_produto add COLUMN nome varchar null;
alter table if exists sysgestao.tb_produto add COLUMN localizacao varchar null;
alter table if exists sysgestao.tb_solicitacao_produto add column id_cliente_destinatario integer null;
alter table if exists sysgestao.tb_pre_solicitacao_produto add column id_cliente_destinatario integer null;
alter table if exists sysgestao.tb_item_pre_solicitacao add column descricao varchar null;
alter table if exists sysgestao.tb_pre_solicitacao_produto alter column nome_destinatario drop not null;
alter table if exists sysgestao.tb_solicitacao_produto alter column nome_destinatario drop not null;


CREATE TABLE IF NOT EXISTS sysgestao.tb_cliente_destinatario (
	id_cliente_destinatario serial not null primary key,
	nome varchar not null,
	endereco varchar,
	cpfCnpj bigint unique,
	idEstrangeiro varchar

);
---END VERSION 3.0


---VERSION 3.1

	create table IF NOT EXISTS sysgestao.tb_login(
		id_login serial not null primary key,
		id_usuario integer not null,
		data_hora timestamp not null,
		tipo integer not null
	);


CREATE TABLE IF NOT EXISTS sysgestao.tb_configura_marketplaces(
	id_marketplace serial not null primary key,
	marketplace varchar not null
);



create table if not exists sysgestao.tb_marketplace_produto(
	id_key serial not null primary key,
	id_marketplace integer not null,
	id_produto integer not null,
	codigo_sku varchar not null,
	constraint id_marketplace_fk foreign key (id_marketplace)
	references sysgestao.tb_configura_marketplaces(id_marketplace),
	constraint id_produto_fk foreign key (id_produto)
	references sysgestao.tb_produto(id_produto)
);

alter table if exists sysgestao.tb_pre_solicitacao_produto add COLUMN if not exists id_marketplace integer null;

--- END VERSION 3.1



--- VERSION 3.2
alter table if exists sysgestao.tb_produto add column if not exists is_kit boolean null;

create table sysgestao.tb_kit_produto (
	id_produto_kit integer not null,
	id_produto_item integer not null,
	quantidade integer not null,
	constraint id_produto_kit_fk foreign key (id_produto_kit)
	references sysgestao.tb_produto(id_produto),
	constraint id_produto_item_fk foreign key(id_produto_item)
	references sysgestao.tb_produto(id_produto)
);
--- END VERSION 3.2



alter table if exists sysgestao.tb_kit_produto add column if not exists quantidade integer null;

select * from sysgestao.tb_produto 
select * from sysgestao.tb_kit_produto
