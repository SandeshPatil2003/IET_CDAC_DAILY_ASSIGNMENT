import { useState, useEffect } from "react";

// Use a map for easier state management and lookup
const charSets = {
  lowercase: "abcdefghijklmnopqrstuvwxyz",
  uppercase: "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
  numbers: "0123456789",
  schar: "!@#$%^&*()",
};

// Simplified Fisher-Yates shuffle function
const shuffleArray = (array) => {
  for (let i = array.length - 1; i > 0; i--) {
    const j = Math.floor(Math.random() * (i + 1));
    [array[i], array[j]] = [array[j], array[i]];
  }
  return array;
};

export default function Pass3() {
  const [selectedOption, setSelectedOption] = useState({
    lowercase: true,
    uppercase: true,
    numbers: true,
    schar: false,
  });

  const [password, setPassword] = useState("");
  const [passLength, setPassLength] = useState(8);

  const handleCheckboxChange = (event) => {
    const { id, checked } = event.target;
    setSelectedOption((prevOptions) => ({
      ...prevOptions,
      [id]: checked,
    }));
  };

  const generatePassword = () => {
    const activeSets = Object.keys(selectedOption).filter(
      (key) => selectedOption[key]
    );

    if (activeSets.length === 0) {
      setPassword("Select character types");
      return;
    }

    let passwordChars = activeSets.map((key) => {
      const set = charSets[key];
      return set[Math.floor(Math.random() * set.length)];
    });

    const combinedCharSet = activeSets.reduce(
      (acc, key) => acc + charSets[key],
      ""
    );

    const remainingLength = passLength - passwordChars.length;
    for (let i = 0; i < remainingLength; i++) {
      passwordChars.push(
        combinedCharSet[Math.floor(Math.random() * combinedCharSet.length)]
      );
    }

    setPassword(shuffleArray(passwordChars).join(""));
  };

  useEffect(() => {
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

      {/* Loop through charSets to create checkboxes */}
      {Object.keys(charSets).map((key) => (
        <div key={key}>
          <label>
            {key.charAt(0).toUpperCase() + key.slice(1)}
            <input
              type="checkbox"
              id={key}
              checked={selectedOption[key]}
              onChange={handleCheckboxChange}
            />
          </label>
        </div>
      ))}
    </>
  );
}