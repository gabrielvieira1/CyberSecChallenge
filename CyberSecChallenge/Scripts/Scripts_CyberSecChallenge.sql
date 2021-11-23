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

insert into Question (Title) values ('O que é o SSID?');
insert into Question (Title) values ('Qual é a primeira etapa para configurar a VPN em um smartphone?');
insert into Question (Title) values ('Qual medida você tomaria para proteger seus dados pessoais?');
insert into Question (Title) values ('Que tipo de rede é definida por dois computadores que podem enviar e receber solicitações para recursos?');
insert into Question (Title) values ('Qual dispositivo de rede é usado para traduzir um nome do domínio para o endereço IP associado?');
insert into Question (Title) values ('Qual é uma vantagem do modelo de rede peer-to-peer?');
insert into Question (Title) values ('Qual é o atraso no tempo em que os dados trafegam entre dois pontos em uma rede?');
insert into Question (Title) values ('Qual é a descrição do tipo de firewall NAT?');
insert into Question (Title) values ('Que prática incorreta não deveria ocorrer nas empresas?');
insert into Question (Title) values ('Frequentemente anexado ao software legítimo, este malware é projectado para rastrear a atividade do usuário.');

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Nome da rede sem fio que deve ser alterado', 1, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Prática recomendada de segurança de ativos de valor para justificar despesas', 1, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Abre a rede sem fio pública', 1, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Algoritmo de criptografia sem fio', 1, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Selecione VPN', 2, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Abra o aplicativo configuraçôes', 2, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Clique em Salvar', 2, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Na seçâo Sem fio e redes, seleccione Mais', 2, 0);

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
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('gateway padrão', 5, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('escalabilidade', 6, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('administração centralizada', 6, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('facilidade de configuração', 6, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('alto nível de segurança', 6, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('latência', 7, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('taxa de transferência', 7, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('goodput', 7, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('largura de banda', 7, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Filtragem baseada em estados de conexâo e portas de dados de origem e destino', 8, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Filtragem com base no programa ou servico', 8, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Filtragem de solicitações de conteúdo da Web', 8, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Oculta ou disfarça os endereços privados de hosts de rede', 8, 1);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Saber quando seus dados estâo indo para a nuvem', 9, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Deixar o notebook/smartphone desbloqueado e sozinho', 9, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Usar a mesma senha para todos os sites', 9, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Fazer backup de dados importantes em mais de um local', 9, 0);

insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Scareware', 10, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Spyware', 10, 1);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Ransomware', 10, 0);
insert into Answer (Alternative, IdQuestion, RightAnswer) values ('Adware', 10, 0);

select * from Question
select * from Answer