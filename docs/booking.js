document.addEventListener("DOMContentLoaded", function () {

    const btn = document.getElementById("buy-tickets");

    btn.addEventListener("click", async function () {

        console.log("CLICKED"); // 👈 kiểm tra

        const quantity = document.getElementById("ticket-quantity").value;
        const email = document.getElementById("ticket-email").value;

        if (!quantity || !email) {
            alert("Nhập thiếu!");
            return;
        }

        try {
            const res = await fetch("http://localhost:5022/api/booking", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    email: email,
                    quantity: parseInt(quantity)
                })
            });

            const data = await res.json();

            console.log(data);
            alert("Đặt vé thành công vui lòng kiểm tra email để thanh toán!");

        } catch (err) {
            console.error(err);
            alert("Lỗi server!");
        }
    });

});
