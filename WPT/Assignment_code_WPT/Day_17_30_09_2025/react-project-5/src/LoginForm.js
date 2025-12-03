import React, { useState } from 'react';

function LoginForm() {
  const [formData, setFormData] = useState({
    username: '',
    password: '',
  });
  const [submittedData, setSubmittedData] = useState(null);
  const [isSubmitted, setIsSubmitted] = useState(false);

  const handleInputChange = (event) => {
    const { name, value } = event.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

  const handleSubmit = (event) => {
    event.preventDefault(); // Prevents the default page reload
    setSubmittedData(formData);
    setIsSubmitted(true);
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial, sans-serif' }}>
      <h1>Login Form</h1>
      
      {isSubmitted ? (
        // Display submitted data
        <div>
          <h2>Submission Successful!</h2>
          <p><strong>Username:</strong> {submittedData.username}</p>
          <p><strong>Password:</strong> {submittedData.password}</p>
        </div>
      ) : (
        // Display the form
        <form onSubmit={handleSubmit} style={{ border: '1px solid #ccc', padding: '20px', borderRadius: '5px', maxWidth: '300px' }}>
          <div style={{ marginBottom: '10px' }}>
            <label htmlFor="username" style={{ display: 'block', marginBottom: '5px' }}>Username:</label>
            <input
              type="text"
              id="username"
              name="username"
              value={formData.username}
              onChange={handleInputChange}
              style={{ width: '100%', padding: '8px', boxSizing: 'border-box' }}
              required
            />
          </div>
          <div style={{ marginBottom: '10px' }}>
            <label htmlFor="password" style={{ display: 'block', marginBottom: '5px' }}>Password:</label>
            <input
              type="password"
              id="password"
              name="password"
              value={formData.password}
              onChange={handleInputChange}
              style={{ width: '100%', padding: '8px', boxSizing: 'border-box' }}
              required
            />
          </div>
          <button type="submit" style={{ width: '100%', padding: '10px', backgroundColor: '#007bff', color: 'white', border: 'none', borderRadius: '5px', cursor: 'pointer' }}>
            Submit
          </button>
        </form>
      )}
    </div>
  );
}

export default LoginForm;