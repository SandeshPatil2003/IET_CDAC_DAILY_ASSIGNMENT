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

export default function Pass4() {
  const [selectedOption, setSelectedOption] = useState({
    lowercase: true,
    uppercase: true,
    numbers: true,
    schar: false,
  });

  const [password, setPassword] = useState("");
  const [passLength, setPassLength] = useState(8);
  const [isCopied, setIsCopied] = useState(false);

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

    let passwordChars = [];
    const combinedCharSet = activeSets.reduce(
      (acc, key) => acc + charSets[key],
      ""
    );

    // Ensure at least one character from each selected set is included
    activeSets.forEach((key) => {
      const set = charSets[key];
      passwordChars.push(set[Math.floor(Math.random() * set.length)]);
    });

    // Fill the rest of the password length
    const remainingLength = passLength - passwordChars.length;
    for (let i = 0; i < remainingLength; i++) {
      passwordChars.push(
        combinedCharSet[Math.floor(Math.random() * combinedCharSet.length)]
      );
    }

    // Shuffle the array and join into a string
    setPassword(shuffleArray(passwordChars).join(""));
  };

  const copyToClipboard = () => {
    navigator.clipboard.writeText(password);
    setIsCopied(true);
    // Reset the copied message after 2 seconds
    setTimeout(() => setIsCopied(false), 2000);
  };

  useEffect(() => {
    generatePassword();
  }, []);

  return (
    <>
      <h1>Password Generator</h1>

      <div>
        <label htmlFor="pass-length">
          Password Length:
          <input
            id="pass-length"
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
        <label htmlFor="generated-password">
          Generated Password:
          <input id="generated-password" type="text" value={password} readOnly />
        </label>
        <button onClick={generatePassword}>Generate Password</button>
        <button onClick={copyToClipboard} disabled={!password}>
          {isCopied ? "Copied!" : "Copy"}
        </button>
      </div>
      <br />

      {Object.keys(charSets).map((key) => (
        <div key={key}>
          <label htmlFor={key}>
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