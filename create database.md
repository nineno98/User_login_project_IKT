create table userdata(\
	userid int AUTO_INCREMENT,\
    username varchar(255) not null,\
    email varchar(255),\
    passwd varchar(255) not null,\
    PRIMARY KEY(userid)\
\
)CHARACTER SET utf8 COLLATE utf8_hungarian_ci;


CREATE USER 'userloginclient'@'localhost' IDENTIFIED BY 'almaeper';\
grant select on userloginapp.* to 'userloginclient'@'localhost'; 


új táblaszerkezet:


create table userdata(\
	userid int AUTO_INCREMENT,\
    username varchar(255) not null,\
    email varchar(255),\
    passwd varchar(255) not null,\
    salt varchar(255) not null,\
    PRIMARY KEY(userid)\
\
)CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
