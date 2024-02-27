SELECT us_lname, us_fname, us_otch, title_position FROM users, positions,
                    authorization_users WHERE login = 'PavlenkoVO' and password = 'PVO1397'
					and authorization_users.id_user = users.id_user and authorization_users.id_position=positions.id_position