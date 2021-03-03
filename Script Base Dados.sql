select * from sys.tables 


drop table cliente
CREATE TABLE CLIENTE (
	ID int IDENTITY(1,1) PRIMARY KEY
	,CODIGO INT NOT NULL
	,NOME VARCHAR(100) NOT NULL
	,DATA_NASC DATETIME
	,FONE_RES  VARCHAR(25)
	,FONE_CEL VARCHAR(25)
	,EMAIL VARCHAR(100)
	,ENDERECO VARCHAR(200)
	,BAIRRO VARCHAR(50)
	,CIDADE VARCHAR(50)
	,OBSERVACAO TEXT
)


DROP TABLE SERVICOS
CREATE TABLE SERVICOS(
	ID INT IDENTITY(1,1) PRIMARY KEY
	,CODIGO INT NOT NULL
	,NOME VARCHAR(100) NOT NULL
	,VALOR FLOAT 
	,DESCRICAO TEXT
)

drop table produto_fornecedor
drop table produto
CREATE TABLE PRODUTO(
	ID INT IDENTITY(1,1) PRIMARY KEY
	,CODIGO INT NOT NULL
	,NOME VARCHAR(100)
	,VALOR FLOAT 
	,DESCRICAO TEXT
)

drop table fornecedor
CREATE TABLE FORNECEDOR (
	ID int IDENTITY(1,1) PRIMARY KEY
	,CODIGO INT NOT NULL
	,NOME VARCHAR(100) NOT NULL
	,FONE_COM  VARCHAR(25)
	,FONE_CEL VARCHAR(25)
	,EMAIL VARCHAR(100)
	,ENDERECO VARCHAR(200)
	,BAIRRO VARCHAR(50)
	,CIDADE VARCHAR(50)
	,OBSERVACAO TEXT
)

CREATE TABLE PRODUTO_FORNECEDOR(
	ID INT IDENTITY(1,1) PRIMARY KEY
	,FK_PRODUTO INT NOT NULL
	,FK_FORNECEDOR INT NOT NULL
	CONSTRAINT [FK_PRODUTO] FOREIGN KEY (FK_PRODUTO) REFERENCES PRODUTO (ID)
	,CONSTRAINT [FK_FORNECEDOR] FOREIGN KEY (FK_FORNECEDOR) REFERENCES FORNECEDOR (ID)
)