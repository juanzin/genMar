use photography;

INSERT INTO TypeUsers(Type)
VALUES('Photographer'),
('Guest')

INSERT INTO Categories(Name)
VALUES('Nature'),
('Portrait')

INSERT INTO Places(Country, State, Name)
VALUES('Mexico', 'Toluca', 'Nevado de Toluca'),
('Mexico', 'Cholula', 'Campos de flor')

INSERT INTO Users(Name, Materno, Username, Password,Instagram, Facebook, Type_User)
VALUES('Juan', 'Onofre', 'Juanzin', 'fotitos', 'https://www.instagram.com/kualtzin_photo/','https://www.facebook.com/', 1)

INSERT INTO Photos(Title, Url_Photo, User_Id, Category_Id, Place_Id)
VALUES('Amanecer', 'https://www.instagram.com/p/DDq5u1CxSpH/', 1, 1, 1)