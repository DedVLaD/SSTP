SELECT us_lname, us_fname, us_otch, title_position FROM users, positions,
                    authorization_users WHERE login = '' and password = ''
					and authorization_users.id_user = users.id_user and authorization_users.id_position=positions.id_position