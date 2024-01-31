
--DATABASE SCRIPT CREATION:
USING filrouge
-- TABLE MATERIEL:  
CREATE TABLEIF NOT EXISTS materiel (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    serviceDat datetime,
    endGarantee datetime,
    
    proprietaireId bigint(20) unsigned,
    FOREIGN KEY (proprietaireId) REFERENCES users(id)
);
 --===========================================================================
   -- PEUPLEMENT DE LA TABLE MATERIEL AVEC 4 ELEMENTS:
INSERT INTO materiel (name, serviceDat, endGarantee, proprietaireId) VALUES 
INSERT INTO materiel (name, serviceDat, endGarantee, proprietaireId) VALUES 
('Ordinateur portable', '2023-01-01', '2025-01-01', 5),
('Imprimante', '2022-05-15', '2024-05-15', 5),
('Projecteur', '2023-03-10', '2025-03-10', 5),
('Casque audio', '2023-07-20', '2025-07-20', 5),
('Écran LCD', '2022-12-10', '2024-12-10', 5);
 -- ===========================================================================
--  Cette instruction sql crée une table appelée category:
CREATE TABLE IF NOT EXISTS category (
  reference INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  PRIMARY KEY (categoryID)
);
--===========================================================================
   -- PEUPLEMENT DE LA TABLE MATERIEL AVEC 4 ELEMENTS:
INSERT INTO category (reference, name) VALUES (1, 'Laptops');
INSERT INTO category (reference, name) VALUES (2, 'Desktops');
INSERT INTO category (reference, name) VALUES (3, 'Servers');
INSERT INTO category (reference, name) VALUES (4, 'Network Equipment');
-- ================================================================================
-- TABLE DE LIAISON CATEGORYMATERIEL:
 create table IF NOT EXISTS CategoryMateriel(
  refCat bigint(20) unsigned,
  idMat bigint(20) unsigned,
  FOREIGN KEY (refCat) REFERENCES category(ref),
  FOREIGN KEY (idMat) REFERENCES materiel(id)
 );  
-- ==============================================================================================================================================