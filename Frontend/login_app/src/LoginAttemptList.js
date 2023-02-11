import React, { useState } from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <li {...props}>{props.children}</li>;

const LoginAttemptList = (props) => {
	const [searchText, setSearchText] = useState('');
	return (
		<div className="Attempt-List-Main">
			<p>Recent activity</p>
			<input type="input" value={searchText} onChange={(e) => { setSearchText(e.target.value) }} placeholder="Filter..." />
			{
				props?.attempts?.filter(o => o.name.includes(searchText))?.map(i => (
					<ul className="Attempt-List">
						<LoginAttempt >Name: {i?.name}<br /> Password: {i?.password}</LoginAttempt>
					</ul>
				))
			}
		</div>
	)
};

export default LoginAttemptList;