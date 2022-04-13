

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
	
	update sysgestao.tb_pre_solicitacao_produto SET data_solicitacao = to_timestamp('07/04/2022', 'dd/MM/yyyy');
	
	select * from sysgestao.tb_pre_solicitacao_produto
	
	update sysgestao.tb_pre_solicitacao_produto set data_solicitacao = to_timestamp('05/04/2022', 'dd/MM/yyyy')
	
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
	
	insert into sysgestao.tb_item_pre_solicitacao(id_pre_solicitacao,
												 codigo_sku,
												 variacao,
												 quantidade) values (1,'SHORT LEGGING ESTAMPA',
																	'Sortida,M 38/40', 1);
	
SELECT S.id_pre_solicitacao, S.nome_destinatario, I.codigo_sku, I.variacao, I.quantidade FROM sysgestao.tb_item_pre_solicitacao as I 
INNER JOIN sysgestao.tb_pre_solicitacao_produto as S ON S.id_pre_solicitacao = I.id_pre_solicitacao 
WHERE S.data_solicitacao >= to_timestamp('01/01/2021', 'dd/MM/yyyy') 
AND S.data_solicitacao <= to_timestamp('07/04/2022', 'dd/MM/yyyy');
	
select * from sysgestao.tb_pre_solicitacao_produto

select I.id_pre_solicitacao, I.codigo_sku, I.variacao, I.quantidade FROM sysgestao.tb_item_pre_solicitacao as I INNER JOIN sysgestao.tb_pre_solicitacao_produto as S ON S.id_pre_solicitacao = I.id_pre_solicitacao WHERE S.data_solicitacao >= to_timestamp('01/01/2022', 'dd/MM/yyyy') AND S.data_solicitacao <= to_timestamp('04/04/2022', 'dd/MM/yyyy');
