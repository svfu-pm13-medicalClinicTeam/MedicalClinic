CREATE TABLE soft_users
(
  id serial NOT NULL,
  login character varying(32),
  hpwd character varying(32),
  CONSTRAINT soft_users_pkey PRIMARY KEY (id),
  CONSTRAINT soft_users_login_key UNIQUE (login)
)