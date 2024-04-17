create table userdata(
	userid int AUTO_INCREMENT,
    username varchar(255) not null,
    email varchar(255),
    passwd varchar(255) not null,
    PRIMARY KEY(userid)

)CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
