# Fitness Machine Analyzer

## Overview

**Fitness Machine Analyzer** is a web application that leverages Machine Learning to analyze gym machines from images. This tool helps users by providing detailed information about each gym machine, including the machine's name, targeted muscles, and instructions on how to use it properly. It's designed to enhance gym experiences by delivering valuable insights about the available equipment.

## Key Features

- **Image Upload**: Users can upload gym machine images for analysis.
- **Machine Analysis**: The application uses a Machine Learning model to identify the machine and provide relevant information.
- **User-friendly Interface**: The app displays the uploaded image and the obtained machine information in an organized, easy-to-read format.

## Functionalities

1. **Image Upload**:
   - Users can upload an image of any gym machine through a simple form.
   - The uploaded image is displayed on the page for confirmation.

2. **Machine Analysis**:
   - By clicking the "Analyze Machine" button, the image is sent to the server for analysis using Machine Learning.
   - Results include:
     - **Machine Name**
     - **Machine Description**
     - **Step-by-step Usage Instructions**, displayed in a numbered list.

3. **Modern User Interface**:
   - The UI is clean and minimalistic, with centrally aligned elements for easy interaction.
   - Machine details are presented in a table for clarity and simplicity.

## Technologies Used

- **Frontend**:
  - Built using HTML, CSS, and Bootstrap for a responsive and modern interface.
  - JavaScript is used for dynamic DOM manipulation and communication with the backend.

- **Backend**:
  - A REST API that processes the image and returns predictions from the Machine Learning model.

- **API**:
  - The API receives an image, processes it, and returns the machine's name, description, and usage steps.

## How to Use

1. **Upload an Image**:
   - Click the "Upload Machine Image" button and select a gym machine image from your device.

2. **Analyze the Machine**:
   - After uploading the image, click the "Analyze Machine" button to send the image for analysis.

3. **View Results**:
   - The uploaded image will be displayed on the page, along with the predicted machine name, description, and usage instructions.

## Installation

To install and run this project locally, follow these steps:

1. Clone the repository:

    ```bash
    git clone https://github.com/DavidSanzMajolero/MLGymMachines.git
    ```

2. Navigate to the project directory:

    ```bash
    cd fitness-machine-analyzer
    ```

3. Install the required dependencies and set up the backend to process the images.

## API

The application utilizes an API that processes uploaded images and returns the recognized machine details.

### Prediction Endpoint

- **URL**: `/api/GymMachines/predict`
- **Method**: `POST`
- **Parameters**: 
   - `file`: The gym machine image file in `multipart/form-data` format.

### Sample Response

```json
{
  "name": "Bench Press",
  "description": "The bench press is a strength training exercise...",
  "usingSteps": [
    "Adjust the bench and load the bar...",
    "Lie on the bench...",
    "Lift the bar from the rack..."
  ]
}
```
![imagen](https://github.com/user-attachments/assets/8fc5756d-c805-428f-b18b-c83a876d4f8b)

![imagen](https://github.com/user-attachments/assets/f7c894aa-d00a-43a2-a57d-a41db5dfc51d)


Thank you for your interest in Fitness Machine Analyzer!
