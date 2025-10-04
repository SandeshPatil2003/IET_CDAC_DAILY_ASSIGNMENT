import { useState, useEffect, useCallback } from "react";

export default function CallbackinPasswordGen() {
  const [selectedOption, setSelectedOption] = useState({
    lowercase: true, 
    uppercase: true,
    numbers: true,
    schar: false,
  });

  const [password, setPassword] = useState("");
  const [passLength, setPassLength] = useState(8);

  const lowercase = "abcdefghijklmnopqrstuvwxyz";
  const uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  const numbers = "0123456789";
  const schar = "!@#$%^&*()";

  const handleCheckboxChange = (event) => {
    const { id, checked } = event.target;
    setSelectedOption((prevOptions) => ({
      ...prevOptions,
      [id]: checked,
    }));
  };

  const generatePassword = () => {
    
    const selectedSets = [];
    if (selectedOption.lowercase) selectedSets.push(lowercase);
    if (selectedOption.uppercase) selectedSets.push(uppercase);
    if (selectedOption.numbers) selectedSets.push(numbers);
    if (selectedOption.schar) selectedSets.push(schar);

    
    if (selectedSets.length === 0) {
      setPassword("Select character types");
      return;
    }

    let generatedPasswordArray = [];
    let remainingLength = passLength;
    let combinedCharSet = "";

    
    selectedSets.forEach(set => {
      generatedPasswordArray.push(set[Math.floor(Math.random() * set.length)]);
      remainingLength--;
      combinedCharSet += set;
    });

    
    for (let i = 0; i < remainingLength; i++) {
      const randomIndex = Math.floor(Math.random() * combinedCharSet.length);
      generatedPasswordArray.push(combinedCharSet[randomIndex]);
    }
    
    
    for (let i = generatedPasswordArray.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [generatedPasswordArray[i], generatedPasswordArray[j]] = [generatedPasswordArray[j], generatedPasswordArray[i]];
    }

    
    setPassword(generatedPasswordArray.join(""));
};

  
  useCallback(() => {
    generatePassword();
  }, []);

  return (
    <>
      <h1>Password Generator</h1>

      <div>
        <label>
          Password Length:
          <input
            type="number"
            value={passLength}
            onChange={(e) => setPassLength(Number(e.target.value))}
            min="1"
            max="30"
          />
        </label>
      </div>

      <br />
      <div>
        <label>
          Generated Password:
          <input type="text" value={password} readOnly />
        </label>
        <button onClick={generatePassword}>Generate Password</button>
      </div>
      <br />

      <div>
        <label>Lowercase
          <input
            type="checkbox"
            id="lowercase"
            checked={selectedOption.lowercase}
            onChange={handleCheckboxChange}
          />
          
        </label>
      </div>

      <div>
        <label>Uppercase
          <input
            type="checkbox"
            id="uppercase"
            checked={selectedOption.uppercase}
            onChange={handleCheckboxChange}
          />
          
        </label>
      </div>

      <div>
        <label>
            Numbers
          <input
            type="checkbox"
            id="numbers"
            checked={selectedOption.numbers}
            onChange={handleCheckboxChange}
          />
          
        </label>
      </div>

      <div>
        <label>Special Characters
          <input
            type="checkbox"
            id="schar"
            checked={selectedOption.schar}
            onChange={handleCheckboxChange}
          />
          
        </label>
      </div>
    </>
  );
}