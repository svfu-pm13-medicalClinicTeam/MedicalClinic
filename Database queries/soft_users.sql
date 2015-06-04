-- Table: soft_users

-- DROP TABLE soft_users;

CREATE TABLE soft_users
(
  id integer NOT NULL,
  login character varying(40),
  hpwd character varying(32),
  CONSTRAINT soft_users_pkey PRIMARY KEY (id),
  CONSTRAINT soft_users_unique_login UNIQUE (login)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE soft_users
  OWNER TO postgres;
