USE labeled_data;

DROP TABLE IF EXISTS `labeled_data`;

CREATE TABLE `labeled_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `topic_id` int(11) NOT NULL,
  `content` text COLLATE utf8_bin,
  `score` float DEFAULT NULL,
  `file_audio` text COLLATE utf8_bin,
  `file_image` text COLLATE utf8_bin,
  `question` text COLLATE utf8_bin,
  `english_test_id` int(11) NOT NULL,
  `test_format_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `user_id_idx` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

DROP TABLE IF EXISTS `mst_category`;

CREATE TABLE `mst_category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text COLLATE utf8_bin NOT NULL,
  `tag_type` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

DROP TABLE IF EXISTS `mst_english_type`;

CREATE TABLE `mst_english_type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tag_type` int(11) NOT NULL,
  `name` text COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

DROP TABLE IF EXISTS `tbl_user`;

CREATE TABLE `tbl_user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `login_name` text COLLATE utf8_bin NOT NULL,
  `full_name` text COLLATE utf8_bin NOT NULL,
  `password` text COLLATE utf8_bin NOT NULL,
  `rule` int(11) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

INSERT INTO `labeled_data`.`tbl_user`(`login_name`,`full_name`,`password`,`rule`)
VALUES('admin','admin','$pbkdf2$10000$fIqEcPW9YIn1AJrsPxXDbA$MTNdtGqJh5Wr6WjIeiXGyh4JDHk',0);

INSERT INTO `labeled_data`.`mst_english_type`(`tag_type`,`name`)
VALUES
	(0,'English Test'),
	(1,'Test Format'),
	(2,'Topic');

DELIMITER $$
DROP PROCEDURE IF EXISTS `get_labeled_data`;
CREATE PROCEDURE get_labeled_data (
IN topic_id INT,
IN english_test_id INT,
IN test_format_id INT,
OUT topic TEXT,
OUT english_test TEXT,
OUT test_format TEXT
)
BEGIN
	SET topic = (
		SELECT m.name FROM labeled_data l
		INNER JOIN mst_category m
		ON l.topic_id = m.id
		WHERE m.id = topic_id
        LIMIT 1
    );
    
    SET english_test = (
		SELECT m.name FROM labeled_data l
		INNER JOIN mst_category m
		ON l.english_test_id = m.id
		WHERE m.id = english_test_id
        LIMIT 1
    );
    
    SET test_format = (
		SELECT m.name FROM labeled_data l
		INNER JOIN mst_category m
		ON l.test_format_id = m.id
		WHERE m.id = test_format_id
        LIMIT 1
    );
END$$
DELIMITER ;