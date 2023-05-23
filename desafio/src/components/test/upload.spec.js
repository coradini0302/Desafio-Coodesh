import { fireEvent, render } from "@testing-library/react";
import { BrowserRouter } from "react-router-dom";
import Header from "../../views/shared/Header";
import "@testing-library/jest-dom";

jest.mock('react-router-dom', () => {
    
})

describe("upload", () => {
    it("should render correctly", () =>{
        render(
            <BrowserRouter>
                <Header />
            </BrowserRouter>
        )
            const btnImport = screen.getByText("Import");

            fireEvent.click(btnImport);

        expect(screen.getByText("Upload file .txt")).toBeInTheDocument();
    })
})