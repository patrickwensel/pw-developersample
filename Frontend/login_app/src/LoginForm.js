import React from "react";
import './LoginForm.css';

const LoginForm = (props) => {
	const handleSubmit = (event) => {
		event.preventDefault();

		props.onSubmit({
			name: event?.target?.name?.value,
			password: event?.target?.password?.value,
		});
	}

	return (
		<form className="form" onSubmit={handleSubmit}>
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name" />
			<label htmlFor="password">Password</label>
			<input type="password" id="password" />
			<button type="submit">Continue</button>
		</form>
	)
}

export default LoginForm;