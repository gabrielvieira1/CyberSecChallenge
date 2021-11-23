Create database cybersec-challeng-db

CREATE TABLE Question (
    Id int identity(1,1) primary key,
    Title varchar(500),
    Active bit default(1)
);

CREATE TABLE Answer (
    Id int identity(1,1) primary key,
    Alternative varchar(500),
    IdQuestion int,
	RightAnswer bit,
    Active bit default(1)
);

CREATE TABLE Player (
    Id int identity(1,1) primary key,
    Nome varchar(200),
    Email varchar(200)
);

CREATE TABLE Challenge (
    Id int identity(1,1) primary key,
    IdPlayer int,
    Score int
);

insert into Question (Title) values ('O que � o SSID?');
insert into Question (Title) values ('Qual � a primeira etapa para configurar a VPN em um smartphone?');
insert into Question (Title) values ('Qual medida voc� tomaria para proteger seus dados pessoais?');
insert into Question (Title) values ('Que tipo de rede � definida por dois computadores que podem enviar e receber solicita��es para recursos?');
insert into Question (Title) values ('Qual dispositivo de rede � usado para traduzir um nome do dom�nio para o endere�o IP associado?');
insert into Question (Title) values ('Qual � uma vantagem do modelo de rede peer-to-peer?');
insert into Question (Title) values ('Qual � o atraso no tempo em que os dados trafegam entre dois pontos em uma rede?');
insert into Question (Title) values ('Qual � a descri��o do tipo de firewall NAT?');
insert into Question (Title) values ('Que pr�tica incorreta n�o deveria ocorrer nas empresas?');
insert into Question (Title) values ('Frequentemente anexado ao software leg�timo, este malware � projectado para rastrear a atividade do usu�rio.');

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Nome da rede sem fio que deve ser alterado', 1, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Pr�tica recomendada de seguran�a de ativos de valor para justificar despesas', 1, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Abre a rede sem fio p�blica', 1, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Algoritmo de criptografia sem fio', 1, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Selecione VPN', 2, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Abra o aplicativo configura��es', 2, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Clique em Salvar', 2, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Na se��o Sem fio e redes, seleccione Mais', 2, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Fazer backup apenas uma vez no ano', 3, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Transmitir o SSID da rede sem fio', 3, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Compartilhar suas senhas com os amigos', 3, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Use senhas fortes', 3, 1);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('peer-to-peer', 4, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('campus', 4, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('cliente/servidor', 4, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('empresa', 4, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('roteador', 5, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Servidor DNS', 5, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('servidor DHCP', 5, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('gateway padr�o', 5, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('escalabilidade', 6, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('administra��o centralizada', 6, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('facilidade de configura��o', 6, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('alto n�vel de seguran�a', 6, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('lat�ncia', 7, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('taxa de transfer�ncia', 7, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('goodput', 7, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('largura de banda', 7, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Filtragem baseada em estados de conex�o e portas de dados de origem e destino', 8, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Filtragem com base no programa ou servico', 8, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Filtragem de solicita��es de conte�do da Web', 8, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Oculta ou disfar�a os endere�os privados de hosts de rede', 8, 1);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Saber quando seus dados est�o indo para a nuvem', 9, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Deixar o notebook/smartphone desbloqueado e sozinho', 9, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Usar a mesma senha para todos os sites', 9, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Fazer backup de dados importantes em mais de um local', 9, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Scareware', 10, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Spyware', 10, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Ransomware', 10, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Adware', 10, 0);

select * from Question
select * from Answer