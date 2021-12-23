CREATE TABLE tab_authors
(
    id         INT         NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name  VARCHAR(75) NOT NULL
);

CREATE TABLE tab_genres
(
    id   INT         NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL
);

CREATE TABLE tab_publishing_houses
(
    id   INT          NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL
);

CREATE TABLE tab_books
(
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    id_author INT NOT NULL,
    year_of_creation YEAR,
    id_genre INT NOT NULL,
    FOREIGN KEY (id_author) REFERENCES tab_authors (id) 
        ON DELETE NO ACTION 
        ON UPDATE NO ACTION,
    FOREIGN KEY (id_genre) REFERENCES tab_genres (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tab_editions (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    id_book INT NOT NULL,
    id_publishing_house INT NOT NULL,
    number_of_pages INT NOT NULL,
    year_of_publishing YEAR NOT NULL,
    FOREIGN KEY (id_book) REFERENCES tab_books (id) 
        ON UPDATE NO ACTION 
        ON DELETE NO ACTION,
    FOREIGN KEY (id_publishing_house) REFERENCES tab_publishing_houses (id)
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
);

CREATE TABLE tab_prices (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    id_edition INT NOT NULL,
    cost DOUBLE NOT NULL,
    price DOUBLE NOT NULL,
    FOREIGN KEY (id_edition) REFERENCES tab_editions (id)
        ON UPDATE NO ACTION 
        ON DELETE NO ACTION 
);