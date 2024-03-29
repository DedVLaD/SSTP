INSERT INTO bs_baikal.users VALUES ('user1','Игоренко','Алексей','Олегович','1998-01-20');
INSERT INTO bs_baikal.users VALUES ('user2','Евренко','Владислав','Сергеевич','1985-07-19');
INSERT INTO bs_baikal.users VALUES ('user3','Калимуллов','Дмитрий','Чукович','1983-09-18');
INSERT INTO bs_baikal.users VALUES ('user4','Игорев','Руслан','Александрович','1990-07-21');
INSERT INTO bs_baikal.users VALUES ('user5','Артурова','Алина','Дмитриевна','1991-10-29');
INSERT INTO bs_baikal.users VALUES ('user6','Черепанов','Петр','Васильевич','1986-12-11');
INSERT INTO bs_baikal.users VALUES ('user7','Иринина','Марина','Арсеновна','1961-03-15');
INSERT INTO bs_baikal.users VALUES ('user8','Туленов','Евгений','Сергеевич','1966-02-07');
INSERT INTO bs_baikal.users VALUES ('user9','Алинина','Алена','Викторовна','1979-09-05');
INSERT INTO bs_baikal.users VALUES ('user10','Тавров','Игорь','Николаевич','1971-11-16');
INSERT INTO bs_baikal.users VALUES ('user11','Вилнкинс','Арсен','Валерьевич','1985-05-20');
INSERT INTO bs_baikal.users VALUES ('user12','Уголова','Антонина','Николаевна','1989-01-19');

INSERT INTO bs_baikal.positions VALUES ('pos1','Генеральный директор');
INSERT INTO bs_baikal.positions VALUES ('pos2','Главный химик-технолог');
INSERT INTO bs_baikal.positions VALUES ('pos3','Главный инженер');
INSERT INTO bs_baikal.positions VALUES ('pos4','Главный энергетик');
INSERT INTO bs_baikal.positions VALUES ('pos5','Старший мастер');
INSERT INTO bs_baikal.positions VALUES ('pos6','Главный бухгалтер');
INSERT INTO bs_baikal.positions VALUES ('pos7','Заведующий складом');
INSERT INTO bs_baikal.positions VALUES ('pos8','Начальник лаборатории');
INSERT INTO bs_baikal.positions VALUES ('pos9','Специалист по охране труда');
INSERT INTO bs_baikal.positions VALUES ('pos10','Юрист');
INSERT INTO bs_baikal.positions VALUES ('pos11','Мастер производства эмульгатора');
INSERT INTO bs_baikal.positions VALUES ('pos12','Лаборант');

INSERT INTO bs_baikal.authorization_users VALUES ('user1','pos11','PVOuser','UFZPMTM5Nw==');
INSERT INTO bs_baikal.authorization_users VALUES ('user2','pos11','SASuser','U0FTMjM4OQ==');
INSERT INTO bs_baikal.authorization_users VALUES ('user3','pos11','ARCuser','QVJDSDMyOTg=');
INSERT INTO bs_baikal.authorization_users VALUES ('user4','pos11','SAAuser','U0FBMTI2NQ==');
INSERT INTO bs_baikal.authorization_users VALUES ('user5','pos12','PYDuser','UFlENDk2Nw==');
INSERT INTO bs_baikal.authorization_users VALUES ('user6','pos2','CMVuser','Q01WOTYxMw==');
INSERT INTO bs_baikal.authorization_users VALUES ('user7','pos8','VIAuser','VklBNzQ1Mg==');
INSERT INTO bs_baikal.authorization_users VALUES ('user8','pos5','GGSuser','R0dTNDU2Mw==');
INSERT INTO bs_baikal.authorization_users VALUES ('user9','pos7','DLVuser','RFZMMjM2NA==');
INSERT INTO bs_baikal.authorization_users VALUES ('user10','pos3','SANuser','U0FONzQxMg==');
INSERT INTO bs_baikal.authorization_users VALUES ('user11','pos1','VDVuser','VkRWODg1Ng==');
INSERT INTO bs_baikal.authorization_users VALUES ('user12','pos6','UNVuser','VU5WNDU5Ng==');

INSERT INTO bs_baikal.container VALUES ('1','Б/У бочки'); 
INSERT INTO bs_baikal.container VALUES ('2','Новые бочки'); 
INSERT INTO bs_baikal.container VALUES ('3','Б/У кубы грязные'); 
INSERT INTO bs_baikal.container VALUES ('4','Б/У кубы чистые'); 
INSERT INTO bs_baikal.container VALUES ('5','Новые кубы'); 

INSERT INTO bs_baikal.labels VALUES ('1','ЭП-1 НИПИГОРМАШ'); 
INSERT INTO bs_baikal.labels VALUES ('2','ЭП-5 НИПИГОРМАШ'); 
INSERT INTO bs_baikal.labels VALUES ('3','ЭП-11 НИПИГОРМАШ'); 
INSERT INTO bs_baikal.labels VALUES ('4','ЭП-5 БАЙКАЛ'); 
INSERT INTO bs_baikal.labels VALUES ('5','BSP-3380 БАЙКАЛ'); 

INSERT INTO bs_baikal.location VALUES ('1','Производственный участок'); 
INSERT INTO bs_baikal.location VALUES ('2','Склад'); 
INSERT INTO bs_baikal.location VALUES ('3','Отгружен'); 

INSERT INTO bs_baikal.status VALUES ('1','Согласование с Главным химиком'); 
INSERT INTO bs_baikal.status VALUES ('2','Активен'); 
INSERT INTO bs_baikal.status VALUES ('3','Закрыт'); 


INSERT INTO bs_baikal.titlegp VALUES ('1','ЭП-1'); 
INSERT INTO bs_baikal.titlegp VALUES ('2','ЭП-5'); 
INSERT INTO bs_baikal.titlegp VALUES ('3','ЭП-11'); 
INSERT INTO bs_baikal.titlegp VALUES ('4','BSP-3380'); 

INSERT INTO `bs_baikal`.`customers` (`name_customer`, `telephone`, `adress`) VALUES ('Курмагка', '+7 996 546 12 25', 'п. Курманка, Улица Витязя 1');
INSERT INTO `bs_baikal`.`customers` (`name_customer`, `telephone`, `adress`) VALUES ('Мыски', '+7 987 445 12 36', 'Мыски, Улица Пушкина, дом Колотушкина');
INSERT INTO `bs_baikal`.`customers` (`name_customer`, `telephone`, `adress`) VALUES ('НПГМ', '+7 969 654 21 36', 'Екатеринбург, Симская 1');
INSERT INTO `bs_baikal`.`customers` (`name_customer`, `telephone`, `adress`) VALUES ('Анталия', '+7 981 369 21 58', 'Нижний Новгород, Улица Сибирская 98');
INSERT INTO `bs_baikal`.`customers` (`name_customer`, `telephone`, `adress`) VALUES ('Гарант', '+7 938 547 36 98', 'Москва, Улица Ленина 1');


INSERT INTO `bs_baikal`.`orders` (`id_order`, `id_customer`, `data_order_formation`, `end_date_agreement`, `id_label`, `id_titleGP`, `id_container`, `id_location`, `id_status`) VALUES ('100', '2', '2024-02-01', '24-02-03', '3', '2', '3', '1', '1');
INSERT INTO `bs_baikal`.`orders` (`id_customer`, `data_order_formation`, `end_date_agreement`, `id_label`, `id_titleGP`, `id_container`, `id_location`, `id_status`) VALUES ('1', '2024-02-01', '2024-02-03', '1', '1', '1', '1', '1');

INSERT INTO `bs_baikal`.`compositionorder` (`id_composition_order`, `composition_order`, `passport`, `weight_kg`) VALUES ('100', '3 ЭОКа, 1 ПЭАЯК + допы', '№326 от 2024-07-14', '52000');
INSERT INTO `bs_baikal`.`compositionorder` (`id_composition_order`, `composition_order`, `passport`, `weight_kg`) VALUES ('101', '2 ЭОКа, 2 ПЭАЯК + допы', '№327 от 2024-07-14', '18000');


INSERT INTO `bs_baikal`.`productbatchgp` (`id_productBatchGP`, `id_composition_order`, `begin_production_date`, `end_production_date`, `viscosity`, `electrical_capacity`) VALUES ('400', '100', '2024-02-03', '2024-02-05', '700', '87');
INSERT INTO `bs_baikal`.`productbatchgp` (`id_composition_order`, `begin_production_date`, `end_production_date`, `viscosity`, `electrical_capacity`) VALUES ('101', '2024-02-05', '2024-02-06', '750', '90');



INSERT INTO `bs_baikal`.`productbatchpayak` (`id_productBatchPAYAK`, `id_productBatchGP_PAYAK`, `begin_production_date_PAYAK`, `end_production_date_PAYAK`, `acid_number_PAYAK`, `comment_PAYAK`) VALUES ('200', '400', '2024-02-05', '2024-02-06', '11', 'В норме');
INSERT INTO `bs_baikal`.`productbatchpayak` (`id_productBatchGP_PAYAK`, `begin_production_date_PAYAK`, `end_production_date_PAYAK`, `acid_number_PAYAK`, `comment_PAYAK`) VALUES ('401', '2024-02-05', '2024-02-06', '20', 'В норме');
INSERT INTO `bs_baikal`.`productbatchpayak` (`id_productBatchGP_PAYAK`, `begin_production_date_PAYAK`, `end_production_date_PAYAK`, `acid_number_PAYAK`, `comment_PAYAK`) VALUES ('400', '2024-02-06', '2024-02-07', '15', 'Слегка отличается по цвету, более светлый');

INSERT INTO `bs_baikal`.`productbatcheok` (`id_productBatchEOK`, `id_productBatchGP_EOK`, `begin_production_date_EOK`, `end_production_date_EOK`, `acid_number_EOK`, `comment_EOK`) VALUES ('416', '400', '2024-02-05', '2024-02-06', '16', 'В норме');
INSERT INTO `bs_baikal`.`productbatcheok` (`id_productBatchGP_EOK`, `begin_production_date_EOK`, `end_production_date_EOK`, `acid_number_EOK`, `comment_EOK`) VALUES ('400', '2024-02-06', '2024-02-07', '11', 'В норме');
INSERT INTO `bs_baikal`.`productbatcheok` (`id_productBatchGP_EOK`, `begin_production_date_EOK`, `end_production_date_EOK`, `acid_number_EOK`, `comment_EOK`) VALUES ('400', '2024-02-06', '2024-02-07', '15', 'Слишком густой');
INSERT INTO `bs_baikal`.`productbatcheok` (`id_productBatchGP_EOK`, `begin_production_date_EOK`, `end_production_date_EOK`, `acid_number_EOK`, `comment_EOK`) VALUES ('401', '2024-02-07', '2024-02-08', '15', 'В норме');
